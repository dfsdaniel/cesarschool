using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ExemploWebRequest
{
    [DataContract]
    public class ListagemFotos
    {
        [DataMember(Name = "photos")]
        public List<string> Fotos;
    }
}
