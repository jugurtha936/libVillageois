namespace libVillageois
{
    public class Villageois
    {
        private bool malade;
        private string _nom;
        private int _poids;

            public Villageois (string nom,int poids,bool malade)
        {
            this._nom = nom;
            this._poids = poids;    
            this.malade = malade;
        }
        public Villageois(string nom)
        {
            this._nom = nom;
            this.malade=false;

        }
        public bool getMalade ( )
        {
            return malade;
        }
        public string getnom ( )
        {
            return _nom;
        }
        public int getpoid ( )
        {
            return _poids;
        }
        public override string ToString()
        {
            string malade = "pas malade";
           if ( this.malade )
            {
                string malade = "est malade";
            }
            

                return "Le villageois ce nomme" + _nom + "peut soulever" + _poids + "et est"+ malade;
        }
        public void setPoids(int poids)
        {
            this._poids = poids;
        }
        public int poidsSouleve(int poids)
        {
            return (_poids/5);
        }
        public bool soulevementpoids (Villageois gaulois)
        {
            if (this.poids==gaulois.getpoid)
        }

    }
}
