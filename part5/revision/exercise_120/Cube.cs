namespace exercise_120
{
    class Cube
    {
        public int edgeLength{ get; set; }
        private int volume;
       
        public Cube(int edgeLength)
        {
            this.edgeLength = edgeLength;
           
        }


        public int Volume()
        {
        
        return this.volume = this.edgeLength * this.edgeLength * this.edgeLength;
        }
        public override string ToString()
        {
          return "The length of the edge is " + this.edgeLength + " and the volume " + this.Volume(); 
        }
    }

}