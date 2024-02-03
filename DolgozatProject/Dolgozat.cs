namespace DolgozatProject
{

    public class Dolgozat
    {
        private List<int> pontok;

        public Dolgozat()
        {
            pontok = new List<int>();
        }
        public void PontFelvesz(int x)
        {
            if (x < -1 || x > 100)
            {
                throw new ArgumentException("Érvénytelen paraméter. A pontszámnak -1 és 100 között kell lennie.");
            }

            pontok.Add(x);
        }
        public List<int> Pontok
        {
            get { return pontok; }
        }

        public bool MindenkiMegirta()
        {
            if(pontok.Any(pont => pont == -1)) {
                throw new ArgumentException("Nem mindenki írta meg a dolgozatot");
            } else return true;
        }

        public int Bukas
        {
            get
            {
                int count = 0;
                foreach (int pont in pontok)
                {
                    if (pont >= 0 && pont < 50)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public int Elegseges
        {
            get
            {
                int count = 0;
                foreach (int pont in pontok)
                {
                    if (pont >= 50 && pont < 60)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public int Kozepes
        {
            get
            {
                int count = 0;
                foreach (int pont in pontok)
                {
                    if (pont >= 61 && pont < 70)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public int Jo
        {
            get
            {
                int count = 0;
                foreach (int pont in pontok)
                {
                    if (pont >= 71 && pont < 80)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public int Jeles
        {
            get
            {
                int count = 0;
                foreach (int pont in pontok)
                {
                    if (pont >= 80)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public bool Gyanus(int kivalok)
        {
            if (kivalok < 0)
            {
                throw new ArgumentException("A kiváló tanulók száma nem lehet negatív.");
            }

            int jelesek = pontok.Count(pont => pont > 80);
            if (jelesek > kivalok) {
                throw new ArgumentException("Gyanúsan sok kiváló!!!");
            }
            return false;
        }

        public bool Ervenytelen
        {
            get
            {
                int count = 0;
                foreach (int pont in pontok)
                {
                    if (pont == -1)
                    {
                        count++;
                    }
                }

                return count >= pontok.Count / 2;
            }
        }
    }
}


