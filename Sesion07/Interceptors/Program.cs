using Microsoft.EntityFrameworkCore;

var optionsBuilder = new DbContextOptionsBuilder<BlogContext>();
optionsBuilder.UseNpgsql("Host=localhost; Database=postgres; Username=postgres;Password=example");

var ctx =  new BlogContext(optionsBuilder.Options);
var blogs = ctx.Blogs.TagWith("Use hint: robust plan").ToList();

