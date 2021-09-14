using System;

namespace CLass_Libary
{
    /// <summary>
    ///  This class Function is to create instances of football players 
    /// </summary>
    public class FootBallPlayer
    {
        /// <summary>
        ///  This constructor is an open constructor where you can create an object with null values on all properties
        ///  
        /// </summary>
        public FootBallPlayer()
        {

        }
        public FootBallPlayer(int id,string name, double price, int shirtName)
        {
            Id = id;
            Name = name;
            Price = price;
            ShirtNumber = shirtName;
        }
        /// <param Id>Id is ust to identify different instances of footplayers </param>
        public int Id { get; set; }

        /// <param Name> 
        /// Name has to be atleast 4 chars long, if name is not 4 chars long the system 
        /// will throw exception telling user that it must be atlesat 4 chars long. 
        /// </param>

        private string name;
        public string Name   
        {
            get { return name; }  
            set { if(value.Length >= 4)
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Name must contain atlesat 4 characters");
                }
                } 
        }

        /// <param Price> 
        // Shows the price of a given footballplayer, the footballplayers' price must be over 0, if not the system will throw an excpetion telling the user that the price must be over 0.
        /// </param>
   
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Price must be over 0");
                }
            }
        }
        /// <param shirtNumber> 
         // shirtnumber shows which number the specefic player has on he's shirt, and can only be a number between 0 and 101 /
        /// </param>
        private int shirtNumber;
        public int ShirtNumber
        {
            get { return shirtNumber; }
            set
            {
                if (value > 0 && value < 101)
                {
                    shirtNumber = value;
                }
                else if (value > 0)
                {
                    throw new ArgumentOutOfRangeException("You must place a value higher then 0 and between 0 and 101");
                }
                else
                {
                    throw new ArgumentOutOfRangeException("You must place a value lower then 101 and between 0 and 101");
                }
            }
        }

    }
}
