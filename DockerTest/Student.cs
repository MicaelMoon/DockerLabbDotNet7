namespace DockerTest
{
	public class Student
	{
		public string Id { get; set; } = Guid.NewGuid().ToString();
		public string Name { get; set; }
		public string Email { get; set; }
	}
}
