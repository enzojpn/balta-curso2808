// See https://aka.ms/new-console-template for more information
using Blog.Data;
using Blog.Models;

Console.WriteLine("Hello, World!");

using (var context = new BlogDataContext()){
     
    
    
    var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
    tag.Name = "DOTNET";
    tag.Slug = "dotnet";
    context.Update(tag);
    
    context.SaveChanges();

    var tags = context.Tags.Where(t => t.Name.Contains("JAV")).ToList( );
    foreach (var item in tags)
    {
        Console.WriteLine(item.Name);
    }



}
