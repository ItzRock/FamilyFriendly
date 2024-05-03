[![Forks][forks-shield]][forks-url]
[![Issues][issues-shield]][issues-url]
[![Stargazers][stars-shield]][stars-url]
[![Thunderstore Downloads][thunderstore-shield]][thunderstore-url]

# Family Friendly
![Logo](https://github.com/ItzRock/FamilyFriendly/blob/main/icon.png)

An adjustable non serious mod that kills you if you swear.

[GitHub](https://github.com/ItzRock/FamilyFriendly), [Thunderstore](https://thunderstore.io/c/content-warning/p/AnthonyStai/FamilyFriendly/)

## How to customize
Modify the included "naughtywords.txt" file in the plugin's directory to any words you'd like seperated by a new line. This mod intentionally doesn't include many swear words as the mod REALLY likes to false positive.

If you would like include this mod in a modpack or a translation package please do not include the original DLL file. Please list this mod as a  dependency and add your own "naughtywords.txt" file. It should override it, if it doesn't please open a issue on the GitHub repo.

## Common Issues

### My voice is not being detected?

Press Windows Key + Ctrl + S and if a setup menu pops up, follow that. Make sure your default microphone in Windows is set correctly. If you still have issues please follow the troubleshooting guide for the original LC API found [here](https://github.com/LoafOrc/VoiceRecognitionAPI/wiki/Troubleshooting)

### I'm not saying a swear word but it's still killing me?

Windows voice recognition sucks. I can't fix that so if your using a modified list try reducing its length. I tried using a longer swear list before and I couldn't say anything without it false positive.

I also recommend using [NVIDIA Broadcast](https://www.nvidia.com/en-us/geforce/broadcasting/broadcast-app/) to prevent background false positives, I've had my chair say "shit" apparently.

## Bug Reporting

Please open a issue on the GitHub repo [here](https://github.com/ItzRock/FamilyFriendly/issues). I will respond to them as soon as possible.

## Credits
* [VoiceRecognitionAPI](https://github.com/NotestQ/VoiceRecognitionAPI) for CW port made by [Notest](https://github.com/NotestQ), Original creator [LoafOrc](https://github.com/LoafOrc/VoiceRecognitionAPI). GPL-3.0 licensed. Included in the repository so I can run automated workflows.

## License

Distributed under the GPL-3.0 license. See `LICENSE.txt` for more information.

## Contributing

If you would like to contribute please fork the repository, change the version number, and open a pull request. If I do not review it right away please ping me in the [Content Warning modding Discord server](https://discord.gg/yeGDSm4gFq) I am @anthony.stai

[contributors-shield]: https://img.shields.io/github/contributors/ItzRock/FamilyFriendly.svg?style=for-the-badge
[contributors-url]: https://github.com/ItzRock/FamilyFriendly/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/ItzRock/FamilyFriendly.svg?style=for-the-badge
[forks-url]: https://github.com/ItzRock/FamilyFriendly/network/members
[stars-shield]: https://img.shields.io/github/stars/ItzRock/FamilyFriendly.svg?style=for-the-badge
[stars-url]: https://github.com/ItzRock/FamilyFriendly/stargazers
[issues-shield]: https://img.shields.io/github/issues/ItzRock/FamilyFriendly.svg?style=for-the-badge
[issues-url]: https://github.com/ItzRock/FamilyFriendly/issues
[license-shield]: https://img.shields.io/github/license/ItzRock/FamilyFriendly.svg?style=for-the-badge
[license-url]: https://github.com/ItzRock/FamilyFriendly/blob/master/LICENSE.txt
[thunderstore-shield]: https://img.shields.io/thunderstore/dt/AnthonyStai/FamilyFriendly?style=for-the-badge&logo=thunderstore
[thunderstore-url]: https://thunderstore.io/c/content-warning/p/AnthonyStai/FamilyFriendly/
