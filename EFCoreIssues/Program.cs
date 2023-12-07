using var db = new BloggingContext();

await foreach (var blog in db.Blogs.AsAsyncEnumerable())
{
    var y = 123 + 1;
    // do something
    foreach (var account in blog.Posts)
    {
        // ...
    }
}
