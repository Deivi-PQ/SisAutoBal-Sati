using System;
using System.Collections.Concurrent;
using System.Linq;

namespace SisAutoBal.Web.Models
{
    public class UserTracker
    {
        private readonly ConcurrentDictionary<string, string> _connectedUsers = new ConcurrentDictionary<string, string>();
        private readonly List<ClientesActivos> ListaUser=new List<ClientesActivos>();

        public void AddUser(string connectionId, string userId)
        {
            _connectedUsers.TryAdd(connectionId, userId);
            if (ListaUser.Count > 0)
            {
                ClientesActivos Nuevo = new ClientesActivos(connectionId, userId, DateTime.Now);
                if (!ListaUser.Any(o => o.connectionId == Nuevo.connectionId && o.userId == Nuevo.userId))
                {
                    ListaUser.Add(Nuevo);
                }
                for (int i=0; i<ListaUser.Count;i++)
                {
                    if (ListaUser[i].connectionId == connectionId && ListaUser[i].userId== userId)
                    {
                        ListaUser[i].fecha = DateTime.Now;
                    }
                }
            }
            else
            {
                ClientesActivos Nuevo=new ClientesActivos(connectionId, userId, DateTime.Now);
                if (!ListaUser.Any(o => o.connectionId == Nuevo.connectionId && o.userId == Nuevo.userId))
                {
                    ListaUser.Add(Nuevo);
                }
            }
        }

        public void RemoveUser(string connectionId,int Index)
        {
            _connectedUsers.TryRemove(connectionId, out _);
            ListaUser.RemoveAt(Index);
        }

        public IList<ClientesActivos> GetActiveUsers()
        {
            IList<ClientesActivos> Lista= new List<ClientesActivos>();
            var datos= _connectedUsers.ToList();
            foreach (var connectionId in datos)
            {
                ClientesActivos clientesActivoscli= new ClientesActivos();
                clientesActivoscli.connectionId = connectionId.Key;
                clientesActivoscli.userId = connectionId.Value;
                Lista.Add(clientesActivoscli);
            }

            return ListaUser;
        }
        static void AgregarSinDuplicados<T>(List<T> lista, T objeto)
        {
            if (!lista.Any(item => item.Equals(objeto)))
            {
                lista.Add(objeto);
            }
        }
    }
}
