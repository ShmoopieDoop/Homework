namespace homework_13
{
    public class Actor
    {
        string id;
        int numFilms;
        bool hasOscar;
        public Actor(string id)
        {
            this.id = id;
            this.numFilms = 0;
            this.hasOscar = false;
        }
        public Actor(string id, int numFilms)
        {
            this.id = id;
            this.numFilms = numFilms;
            this.hasOscar = true;
        }
        public void AddFilm()
        {
            this.numFilms++;
        }
        public string Status()
        {
            if (this.numFilms > 50 && this.hasOscar) return "Popular Actor";
            if (this.numFilms > 30 && this.numFilms < 50) return "Successful Actor";
            if (this.numFilms < 10 && this.hasOscar) return "Promising Actor";
            return "Regular Actor";
        }
    }
}