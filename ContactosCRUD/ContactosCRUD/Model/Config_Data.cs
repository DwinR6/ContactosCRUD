using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace ContactosCRUD.Model
{
    public class Config_Data
    {
        SQLiteAsyncConnection DataBase;

        public Config_Data()
        {
            string DbFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ContactosDB");
            DataBase = new SQLiteAsyncConnection(DbFilePath);
            DataBase.CreateTableAsync<Contactos>().Wait();
        }

        public Task<int> AddContact (Contactos contacto)
        {
            return DataBase.InsertAsync(contacto);
        } 

        public Task<Contactos> SeeContactsByID(int id)
        {
            return DataBase.Table<Contactos>().Where(ti => ti.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> UpdateContact (Contactos contacto)
        {
            return DataBase.UpdateAsync(contacto);
        }

        public Task<int> DeleteContact (Contactos contacto)
        {
            return DataBase.DeleteAsync(contacto);
        }
        public Task<List<Contactos>> GetAllContacts()
        {
            return DataBase.Table<Contactos>().ToListAsync();
            
        }

        public Task<List<Contactos>> SearchContact(int id)
        {
            return DataBase.QueryAsync<Contactos>($"SELECT * FROM [Contacts] WHERE [Nombre = { id}");
        }
    }
}
