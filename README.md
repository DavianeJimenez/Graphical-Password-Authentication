## Graphical Password Authentication

Author: Daviane Jimenez

Course: CIS 474 Software Engineering I

Date: 12/2/2022

## Description
This project was inspired by a paper by Parish et al. about image saliency and priming methods for graphical passwords. Users select a "clickpoint" on a randomly assigned image from a pool of 25 images with various priming methods. The system encrypts and stores user information in a local SQL database.

## Key Features
- Random passimage assignment during account creation.
- Implementation in C# and .NET environment.
- Account creation with validation for unique usernames, emails, and password requirements.
- Display of potential passimages in a randomized grid during login.
- Password and passimage ID encryption (partial implementation).

## References
- [MIT Saliency Benchmark](http://saliency.mit.edu/results_cat2000.html)
- Parish, Zach, et al. "A Study on Priming Methods for Graphical Passwords." Journal of Information Security and Applications, vol. 62, 2021, p. 102913. [DOI Link](https://doi.org/10.1016/j.jisa.2021.102913)

**Note:** A SRS document was written for this project. It can be found [here](https://docs.google.com/document/d/1yzXDKIjQzjm7svgNjWQ7VZ9SEu8eCmCypZF2aU2cyso/edit?usp=sharing).
