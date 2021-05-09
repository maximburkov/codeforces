using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeforcesHomework.Homework_4
{
    class Task_L_Cd_And_Pwd : ITask
    {
        class Node
        {
            public Dictionary<string, Node> Children { get; set; } = new Dictionary<string, Node>();
            public Node Parent { get; set; }
            public string Name { get; set; }
        }

        private Node currentDirectory;
        private Node root = new Node { Parent = null, Name = "/" };

        private void ChangeDirectory(string path)
        {
            var splitedPath = path.Split('/');
            int start = 0;

            if (string.IsNullOrEmpty(splitedPath[0]))
            {
                currentDirectory = root;
                start = 1;
            }

            for (int i = start; i < splitedPath.Length; i++)
            {
                string directory = splitedPath[i];
                if (directory == "..")
                {
                    currentDirectory = currentDirectory.Parent;
                }
                else
                {
                    if (currentDirectory.Children.ContainsKey(directory))
                    {
                        currentDirectory = currentDirectory.Children[directory];
                    }
                    else
                    {
                        Node newNode = new Node
                        {
                            Parent = currentDirectory,
                            Name = directory
                        };
                        currentDirectory.Children[directory] = newNode;
                        currentDirectory = newNode;
                    }
                }
            }
        }

        private void Pwd()
        {
            Node currentTraverse = currentDirectory;
            Stack<string> path = new Stack<string>();
            StringBuilder sb = new StringBuilder();

            while (currentTraverse != null)
            {
                path.Push(currentTraverse.Name);
                currentTraverse = currentTraverse.Parent;
            }

            while (path.Any())
            {
                sb.Append(path.Pop());
                sb.Append("/");
            }

            Console.WriteLine(sb.ToString());
        }

        public void Solve()
        {
            int n = int.Parse(Console.ReadLine());

            
            currentDirectory = root;

            for (int i = 0; i < n; i++)
            {
                var buf = Console.ReadLine().Split();

                if(buf[0] == "cd")
                {
                    ChangeDirectory(buf[1]);
                }
                else
                {
                    Pwd();
                }
            }
        }
    }
}
