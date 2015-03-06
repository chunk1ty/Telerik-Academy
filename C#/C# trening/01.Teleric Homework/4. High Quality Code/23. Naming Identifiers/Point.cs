namespace Minesweeper
{ 
    public class Result
    {
        private string name = string.Empty;
        private int score = 0;

        public Result() 
        { 
        }

        public Result(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public string Name
        {
            get 
            { 
                return this.name; 
            }
            set 
            { 
                this.name = value; 
            }
        }

        public int Score
        {
            get 
            { 
                return this.score; 
            }
            set 
            {
                this.score = value; 
            }
        }

        
    }
}