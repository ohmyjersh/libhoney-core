# libhoney-core
.net core adapter for honeycombio integration

MVP:
- [ ] initialization
- [ ] creating events, adding data, and triggering event send
- [ ] asynchronous transmission of those events
- [ ] automated testing core functionality
- [ ] released under the Apache License 2.0

Constructor LibHoney:
- [ ] Team Writekey (no default)
- [ ] Dataset (no default)
- [ ] API Host (default to https://api.honeycomb.io)
- [ ] Sample Rate (defaults to 1)

Events:
- [ ] Make Builder
- [ ] Add Fields
- [ ] Send
- [ ] Validation
- [ ] Serialize nested objects to json strings

Can set at creation of event:
- [ ] Team Writekey
- [ ] Dataset
- [ ] APIHost
- [ ] Sample Rate
- [ ] Timestamp (default: current time)
