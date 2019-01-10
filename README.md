<p align="center"><img  alt="Streamer Notifications" src="./StreamerNotifications/Resources/StreamerNotifications_128x.png"></p>

<h1 align="center">Streamer Notifications</h1>

<div align="center">Show only important messages from your Twitch mods or select community members.</div>

## Features
* Shows messages only from people on a whitelist
* No need to whitelist Twitch staff, admins, global mods, or channel mods
* Highlights whispers/direct messages (still obeys the whitelist)
* Option to only see messages when you are  mentioned *@'ed* (still obeys the whitelist)
* No obtrusive emotes in messages (removes channel, BetterTTV, and FrankerFaceZ emotes)
* Small window size, easy to tuck away somewhere
* Message colors lessen over time so you can ignore them
* Ignores duplicate messages

This is meant to be a super-efficient way of getting important messages from your moderators and people you know/trust who are whitelisted by you.

## How-to use
1) When you run it for the first time it will ask you for an OAuth Token. Some information and a link will be presented for you to read and follow.
2) Follow the steps and obtain your OAuth Token (this is completely safe and private, but do **not** share your token with anyone, even just to test something).

## How messages work 
Message filters are always applied.

* Messages from Twitch staff, admins, and global moderators
  * Users can **not** be blacklisted
* Messages from channel moderators
  * Users can be blacklisted
* All other users
  * Must be whitelisted
