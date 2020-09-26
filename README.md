# Twitch Chatr Bot

The intention of this bot is to provide a way to merge a multitude of external chats into a single twitch channel's chat.

# Configuration

```
"BotConfig": {
    "name": "Chatr",
    "token": "oauth:ChatrToken",
    "channel": "streamer"
    "destinations": [
      "destination1"
    ],
    "sources": [
      "source1"
    ],
    "ignoreChatFrom": [
      "ignore1"
    ],
    "ignoreCommandFrom": [
      "ignore1"
    ],
    "timers": [
        {
            "interval": 0,
            "minInterval": 0,
            "maxInterval": 0,
            "commands": [
                "command1"
            ],
            "type": "<BasicTimer, RandomTimer>"
        }
    ]
},

"DiscordBotConfig": {
    "token": "token",
    "channel": "channel",
    "enabled": false,
},
```

## Twitch Config

1. Name - The bot's name (might not really do anything)
2. Token - OAuth token
3. Channel - This streamer's channel
4. Destinations - Additional channels to echo chat
5. Sources - Co-streamer's that we want to merge chat from
6. IgnoreChatFrom - A list of user's that we should ignore any chat messages
7. IgnoreCommandFrom - A list of user's that we should ignore any commands
8. Timers - A configurable set of timers and type of timers (internal is in ms)

### Timers

A list of timers and what they do

#### BasicTimer

Post one of the commands every configured interval

#### RandomTimer

Post one of the commands between the min and max interval and randomizes each run

## Discord Config

The discord config, all under 'DiscordBotConfig'

1. Token - The discord's token it should use for authentication
2. Channel - The discord channel we are going to listen to and merge into twitch
3. Enabled - Determines if the discord bot should be enabled or not

# Notes

* Can use https://twitchapps.com/tmi/ to create an oauth token
* Seems we must use TCP vs WebSockets, should confirm
* We are setup to only respond to commands from the streamer's channel
* 500 max message size (but use 400 as our limit because we experienced issues using 500)
