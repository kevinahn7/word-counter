# Word Counter

#### Epicodus C# Individual Project #1, June 29th, 2018

#### By Kevin Ahn

## Description

This program takes in a word and a sentence and then returns how many times the first word appeared in the sentence.

## Specs

| Behavior | Input | Output | Explanation |
|----------|-------|--------|-------------|
| Program takes in a phrase | "hello you" | "hello you" | The simplest function would be to take in any phrase
| Program tells you how many times a given word appears in a sentence | "buffalo" "buffalo buffalo buffalo buffalo buffalo" | 5 | Next it would keep track of how many times words were said
| Program tells you how many times a word appears in a sentence | "You and I, or me and you" | You: 2, And: 2, I: 1, Or: 1, Me: 1  | After that, it should be able to differentiate between different words
| Program tells you how many times a given word appears in a sentence with other words present, regardless of case | "And" "And I swear, by the moon and the stars in the sky" | 2 | Finally, it should be able to target specific words and return the count only for that word

## Setup on OSX

* Download and install .Net Core 1.1.4
* Download and install Mono
* Clone the repo
* Run `dotnet restore` from within the project directory

## Contribution Requirements

1. Clone the repo
1. Make a new branch
1. Commit and push your changes
1. Create a PR

## Technologies Used

* .Net Core 1.1.4

## Links

* [The Repository](https://github.com/kevinahn7/word-counter)  
* [The Webpage](https://kevinahn7.github.io/word-counter/)

## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Kevin Ahn**