namespace Assets.Scripts.my.animals
{
	using Assets.Scripts.my.movement;
	public class Dog : Walking
	{
		public static Dog Create(string name)
		{
			return new(
				name,
				new List<Locomotion>(){new Walking()}
			);
		}
	}
}