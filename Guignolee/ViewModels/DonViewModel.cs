using Guignolee.Models;
using System;

namespace Guignolee.ViewModels
{
    public class DonViewModel
    {
        private readonly Don _don;

        public DonViewModel(Don don)
        {
            _don = don;
        }

        public int Id => _don.Id;

        public string Donateur
        {
            get { return _don.Donateur; }
            set
            {
                if (_don.Donateur != value && 2 >= _don.Donateur.Length && _don.Donateur.Length <= 50 )
                {
                    _don.Donateur = value;
                }
            }
        }

        public string Contenu
        {
            get { return _don.Contenu; }
            set
            {
                if (_don.Contenu != value )
                {
                    _don.Contenu = value;
                }
            }
        }

        public int Quantite
        {
            get { return _don.Quantite; }
            set
            {
                if (Quantite != value && Quantite >= 1 && Quantite <= 100)
                {
                    _don.Quantite = value;

                }
            }
        }

        public bool EstPerissable
        {
            get { return _don.EstPerissable; }
            set
            {
                if (_don.EstPerissable != value)
                {
                    _don.EstPerissable = value;
                }
            }
        }

        public bool EstRemis
        {
            get { return _don.EstRemis; }
            set
            {
                if (_don.EstRemis != value)
                {
                    _don.EstRemis = value;
                }
            }
        }

        public DateTime DateReception => _don.DateReception;

        public string Details
        {
            get
            {
                return $"{_don.Quantite} article(s) - {_don.Donateur} - reçu le {_don.DateReception:dd-MM-yyyy}";
            }
        }
        
        public string ValiderDonateur()
        {
            string donateur = Donateur?.Trim() ?? string.Empty;
            if (donateur.Length == 0) return "Le donateur est obligatoire.";
            if (donateur.Length < 2) return "Le donateur doit contenir au moins 2 caractères.";
            if (donateur.Length > 50) return "Le donateur ne peut pas dépasser 50 caractères.";
            return string.Empty;
        }
        public bool EstValide =>
            ValiderDonateur().Length == 0 && ValiderDon().Length == 0 && ValiderQuantite().Length == 0;
    }   
}
