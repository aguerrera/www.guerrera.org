{
  title: "Guerrera.org -- How this blog is made",
  layout: "base"
}

Garoozis: Create Static HTML Files with Razor
---------------------------------------------

1. why
  - f#
  - tinkering is more fun than writing
  - like to understand, easier when you DYI
  - it's not rocket science
  - easy to host on s3
  - could probably have accomplished same with other projects (jekyll, a makefile)
  - i hate wordpress + typepad

2. what
  - build
    - markdown + razor = blog
    - copied conceptually from jekyll (front matter)
    - static html
    - front matter
    - config.js
    - dev server
  - publish
    - s3/azure
    - so much easier than hosting




When I rebuilt this site, I wanted to create my own blogging
engine. That was part of the fun of doing it.  You get to constantly
tinker with the mechanics.  And that's what makes it fun.

So I set out to create my own blog maker.  I hate messing around with
servers: for me, static html works just fine.  So my design choice was
to create a project that some kind of layout templates and some kind
of content templates and slapped them together, and generated static
html.  In turn, I could post this static html to Amazon S3, which is
Amazons storage service.

