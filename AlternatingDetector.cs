namespace cassidoo_2025_12_22
{
	internal class AlternatingDetector
	{
		public static bool IsAlternating(int[] input)
		{
			for(int i = 0; i < input.Length - 2; ++i)
			{
				if (input[i] != input[i+2])
				{
					return false;
				}
			}
			return true;
		}
	}
}
