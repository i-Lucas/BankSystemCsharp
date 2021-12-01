using System;

namespace BankSystemCsharp.Classes
{
    public class Extrato
    {
        public Extrato(DateTime data, string descric, double valor) // Constructor
        {
            this._Data = data;
            this._Descricao = descric;
            this._ExtratoValor = valor;
        }
        // Atributos da classe
        public DateTime _Data {get; private set;}
        public string _Descricao {get; private set;}
        public double _ExtratoValor {get; private set;}

    }
}

//