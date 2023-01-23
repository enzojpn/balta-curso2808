// See https://aka.ms/new-console-template for more information
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

using (var context = new BlogDataContext())
{

    var user = new User()
    {
        Name = "jonas",
        Email = "jon@ghmail.com",
        Slug = "slugjs",
        Image = "imagem",
        PasswordHash = "ajdfgkalfj",
        Bio = "autor de muitos livrosF"

    };

    var category = new Category()
    {
        Name = "programacao",
        Slug = "slug1j"
    };

    var post = new Post()
    {
        Author = user,
        Category = category,
        Title = "titulo",
        Slug = "slug2j",
        Summary = "summary",
        Body = "Corpo do blog",
        CreateDate = DateTime.Now,
        LastUpdateDate = DateTime.Now
    };
    context.Add(user);
    context.Add(category);
    context.Add(post);
    context.SaveChanges();

    
    var posts =    
    context.Posts
    .AsNoTracking()
    .Include(x => x.Author)
    .Where(x=>x.AuthorId == 6)
    .OrderByDescending(x => x.LastUpdateDate)
    .ToList();

    foreach (var item in posts)
    {
        Console.WriteLine($"{item.Title} escrito por {item.Author.Name}");
    }

    // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
    // tag.Name = "DOTNET";
    // tag.Slug = "dotnet";
    // context.Update(tag);

    // context.SaveChanges();

    // var tags = context.Tags.Where(t => t.Name.Contains("JAV")).ToList( );
    // foreach (var item in tags)
    // {
    //     Console.WriteLine(item.Name);
    // }



}
