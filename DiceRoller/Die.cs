using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DiceRoller
{
	/// <summary>
	/// Represents a single six sided die (1 - 6)
	/// </summary>
	public class Die
	{
		/// <summary>
		/// Creates and rolls the die at construction
		/// </summary>
		public Die()
		{
			RollDie();
		}
		/// <summary>
		/// The current value of the die that was rolled
		/// </summary>
        public byte FaceValue { get; private set; }

		/// <summary>
		/// True if the die is held (the player wants to keep the value)
		/// </summary>
		public bool IsHeld { get; set; }

		/// <summary>
		/// Rolls the die and the roll is set to face value <see cref="FaceValue"/>
		/// </summary>
		/// <returns></returns>
        public byte RollDie()
		{
			Random random = new Random();
			FaceValue =  Convert.ToByte(random.Next(1, 7));
			return FaceValue;
		}
	}
}
