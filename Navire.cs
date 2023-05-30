namespace UnitTest___Navire
{
    internal class Navire
    {
        private string noLloyds;
        private string nomNavire;
        private string typeFret;
        private int qteFret;
        
        public Navire(string unNumero, string unNom, string unTypeFret , int uneQte)
        {
            this.noLloyds = unNumero;
            this.nomNavire = unNom;
            this.typeFret = unTypeFret;
            this.qteFret = uneQte;
        }

        public string GetTypeFret()
        {
            return typeFret;
        }

        public int GetQteFret()
        {
            return qteFret;
        }

        public void Decharger(int qteDechargee)
        {
            if(qteDechargee <= this.qteFret)
                this.qteFret -= qteDechargee;
        }

        public bool EstDecharger()
        {
            return this.qteFret == 0;
        }
    }
}
