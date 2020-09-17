# Twitch Chat Merger

The intention of this bot is to provide a way to merge twitch chats while a streamer is co-streaming; we want to 'import' the co-streamer's chat into our chat.

## MVP

* Specify/identify co-streamer and merge chat from their stream into our streamer's chat
* Use the same visual that twitch uses for chat merge if possible
    * If not possible then identify the user in some manner that it's coming from co-stream
* Able to configure bot for each co-streamer
    * Able to specify at least one co-stream but more if possible
        * An upper limit of four-six should be fine
* Easy to run bot
    * Assuming we will probably need the bot to be run locally because the configuration will need to change per co-stream
    * Assuming hosting will be hard because of configuration changes at least until full website available and multi-tenant

## VP

* Able to configure bot to ignore some chat messages
    * Specify users
    * Specify commands (maybe start with anything that starts with !)
* Have random actions the bot can take
    * This should be configurable, action(s) and time
* If possible then the co-streamer's mod control our chat too (i.e. delete messages)
    * Can we confirm this is what twitch does too?
* Allow chat merging from discord too
    * Configurable channel used for chat merging
    * Configurable highlighting of chat merging

# Notes

* Can use https://twitchapps.com/tmi/ to create an oauth token
