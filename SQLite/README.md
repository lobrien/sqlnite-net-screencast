# Screencast: SQLite-net async basics

## Level: Beginner

SQLite is a good choice for relational storage in iOS applications (and mobile applications in general). Frank Kreuger's [sqlite-net](http://github.com/praeclarum/sqlite-net) library provides a small, simple-to-use, and fast wrapper that additionally provides a lightweight object-relational mapper.

This ~10 min. screencast shows the basic use of sqlite-net in MonoTouch. It boils down to 4 steps:

1. Download or git-clone [sqlite-net](http://github.com/praeclarum/sqlite-net) 
2. Add references to the C# files (or you can build your own library, but that's not covered in this screencast)
3. Use annotations in your domain objects to guide the object-relational mapping
4. Use the straightforward API (preferring, in my opinion, asynch operations)

The screencast shows the complete process of writing a (trivial) database app, initializing a table with data in a long-running operation, and providing UI feedback of the non-blocking operation.

The source code and MonoTouch project is also included.