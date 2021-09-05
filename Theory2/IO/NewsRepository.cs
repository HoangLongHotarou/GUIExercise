using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theory2.Models;

namespace Theory2.IO
{
    public class NewsRepository : INewsRepository
    {
        private const string FilePath = "Data\\data.txt";

        public List<Publisher> GetNews()
        {
			List<Publisher> publishers = new List<Publisher>();
			string line;
			Publisher publisher = null;
			if (File.Exists(FilePath))
			{
				using (var stream = new FileStream(FilePath, FileMode.Open, FileAccess.Read))
				{
					using (var reader = new StreamReader(stream))
					{
						while (!reader.EndOfStream)
						{
							line = reader.ReadLine();
							if(line == "")
                            {
								continue;
                            }
                            else if (line.StartsWith("@"))
                            {
								publisher = ParsePublisher(line);
								publishers.Add(publisher);
                            }else if (line.StartsWith("#") && publishers != null)
                            {
								var category = ParseCategory(line);
								publisher.Categories.Add(category);
							}
						}
					}
				}
			}
			return publishers;
		}

		public void Save(List<Publisher> publishers)
        {
			using (var stream = new FileStream(FilePath, FileMode.Open, FileAccess.Write))
			{
				using (var writer = new StreamWriter(stream))
				{
					foreach (var publisher in publishers)
					{
						writer.WriteLine("@{0}", publisher.Name);
                        foreach (var item in publisher.Categories)
                        {
							writer.WriteLine("#{0}^{1}", item.Name,item.RssLink);
						}
						writer.WriteLine("");
					}
				}
			}
		}

		private Publisher ParsePublisher(string line)
        {
			return new Publisher()
			{
				Name = line.Substring(1).Trim()
			};
		}

		private Category ParseCategory(string line)
        {
			string[] str = line.Substring(1).Trim().Split('^');
			return new Category() {
				Name = str[0].Trim(),
				RssLink = str[1].Trim()
			};

        }

	}
}
