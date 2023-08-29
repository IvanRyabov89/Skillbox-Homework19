using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Homework_19_Logics
{
    public class AddModel:IModel

    {
        private string typeFauna;
        /// <summary>
        /// род
        /// </summary>
        private string genus;
        /// <summary>
        /// порода
        /// </summary>
        private string breed;
        /// <summary>
        /// возраст
        /// </summary>
        private string age;
        private ObservableCollection<IFauna> animal;

        public void GetData(string Class, string Genus, string Breed, string Age)
        {
            this.typeFauna = Class;
            this.genus = Genus;
            this.breed = Breed;
            this.age = Age;
          
        }
        public ObservableCollection<IFauna> Result()
        {
            IFauna newFauna = FaunaFactory.GetFauna(typeFauna, genus, breed, age);
            return animal;
        }
    }
}
