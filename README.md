# Project Aurora 2.0
A Discord.NET based multipurpose Discord bot written in C#.
(the first version was written in Python, so I thought I'd rewrite it)

Discord.NET 2.1.1 required to run,
Also make sure you have your bot set up,
Packages not included.

**Creating a Discord Bot**
1. Before writing your bot, it is necessary to create a bot account via the Discord Applications Portal first.
2. Visit the Discord Applications Portal.
3. Create a new application.
4. Give the application a name (this will be the bot's initial username).
5. On the left-hand side, under Settings, click Bot.

![Slika](https://discord.foxbot.me/stable/guides/getting_started/images/intro-bot-settings.png)

Click on Add Bot.

![Slika2](https://discord.foxbot.me/stable/guides/getting_started/images/intro-add-bot.png)

Confirm the popup.

(Optional) If this bot will be public, tick Public Bot.

![Slika2](https://discord.foxbot.me/stable/guides/getting_started/images/intro-public-bot.png)

**Adding your bot to a server**

Bots cannot use invite links; they must be explicitly invited through the OAuth2 flow.

Open your bot's application on the Discord Applications Portal.
On the left-hand side, under Settings, click OAuth2.

![Slika2](https://discord.foxbot.me/stable/guides/getting_started/images/intro-oauth-settings.png)

Scroll down to OAuth2 URL Generator and under Scopes tick bot.

![Slika2](https://discord.foxbot.me/stable/guides/getting_started/images/intro-scopes-bot.png)

Scroll down further to Bot Permissions and select the permissions that you wish to assign your bot with.

*NOTE*

This will assign the bot with a special "managed" role that no one else can use. The permissions can be changed later in the roles settings if you ever change your mind!

Open the generated authorization URL in your browser.

Select a server.
Click on Authorize.

*NOTE*

Only servers where you have the MANAGE_SERVER permission will be present in this list.

![Slika2](https://discord.foxbot.me/stable/guides/getting_started/images/intro-authorize.png)

**Connecting to Discord**
If you have not already created a project and installed Discord.Net, do that now.
