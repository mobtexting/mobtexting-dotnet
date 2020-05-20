# c# plugin for mobtexting

This package makes it easy to send [Mobtexting notifications](https://mobtexting.com).



## Usage

### Send an SMS

```
using System;
using MobtextingDotnet;
namespace Yourprojectnamespace
{
  class message
  {
    static void Main(string[] args)
    {
      string access_token = "xxxxxxxxxxxxxxx";
      Sendsms obj = new Sendsms(ACCESS_TOKEN: access_token);
      string to = "9492xxxxxx";
      string from = "mobsat";
      string body = "hello from c# !";
      char service = 'S';
      obj.sendsms(to, from, body, service);
    }
  }
}

```

