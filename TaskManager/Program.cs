
namespace TaskManager
{
	public class Program
	{
		public static List<Task> tasks = new List<Task>();

		public static void Main(string[] args)
		{
			bool isActive = true;

			while (isActive)
			{
				Console.Clear();
				Console.WriteLine("Welcome to Task Manager, choose an option to apply:");
				Console.WriteLine("1. Add Task.");
				Console.WriteLine("2. View Task(s).");
				Console.WriteLine("3. Mark Task as Done.");
				Console.WriteLine("4. Delete Task.");
				Console.WriteLine("5. Exit");
				Console.WriteLine("Choose an option:");



				switch (Console.ReadLine())
				{
					case "1":
						AddTask();
						break;
					case "2":
						ViewTask();
						break;
					case "3":
						MarkTask();
						break;
					case "4":
						DeleteTask();
						break;
					case "5":
						isActive = false;
						break;
					default:
						Console.WriteLine("Option not found. Press Enter to try again.");
						Console.ReadLine();
						break;
				}

			}
		}

		public static void AddTask()
		{
			Console.Write("Enter task: ");
			var name = Console.ReadLine();
			
			var newTask = new Task(name);
			tasks.Add(newTask);

			Console.WriteLine("Task is added. Press Enter to return to options.");
			Console.ReadLine();
		}

		public static void ViewTask()
		{
			Console.WriteLine("Tasks:");
			if (tasks.Count == 0)
			{
				Console.WriteLine("No tasks added.");
			}
			else
			{
				for (int i = 0; i < tasks.Count; i++)
				{
					var task = tasks[i];
					Console.WriteLine($"{i + 1}.[{(task.IsDone ? "X" : "")}] {task.Name}");
				}
			}
			Console.WriteLine("Press Enter to return to Options.");
			Console.ReadLine();
		}

		public static void MarkTask()
		{
			ViewTask();
			Console.Write("Enter the number of task to be marked as done:");
			if (int.TryParse(Console.ReadLine(), out int i) && i > 0 && i <= tasks.Count)
			{
				tasks[i - 1].IsDone = true;
				Console.WriteLine("Task marked as done. Press Enter to return to options.");
			}
			else
			{
				Console.WriteLine("Invalid task number. Press Enter to retry.");
			}
			Console.ReadLine();
		}
		public static void DeleteTask()
		{

			ViewTask();
			Console.Write("Enter the number of task to be deleted:");
			if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
			{
				tasks.RemoveAt(index - 1);
				Console.WriteLine("Task deleted. Press Enter to return to options.");
			}
			else
			{
				Console.WriteLine("Invalid task number. Press Enter to retry.");
			}
			Console.ReadLine();
		}


		
	}
}

