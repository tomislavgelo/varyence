# InterviewTestApplication

This application is developed for test purposes. 
We ask the Interviewees to make a couple of simple git operations with this repository.

## Story

In the previous sprint, we started the project. We successfully implemented and tested **Feature 1** and right after that we created branch **release1** and launched everything to production. Current sprint we were working on some adjustments and extensions to feature one and started implementing **Feature 2** but didn't finish.
Right now we are trying to make and prepare the next release branch and maybe we would like to roll out a couple of fixes to the previous release.

## Instruction
Please, clone this repository into your own and complete all key items listed below. After everything is done, send us back a link to your repository. Please, make sure it's public and we are able to check the results.
Thanks.

## Key Items

1. Fork the next release branch from **main** branch and name it **release2**
2. Exclude [last merge request](https://gitlab.com/andrey.maslyanko96/interviewtestapplication/-/merge_requests/6) from **release2** using git cli or other git tools.
3. Exclude [feature 1 validator](https://gitlab.com/andrey.maslyanko96/interviewtestapplication/-/merge_requests/2) from **release2** using git cli or other git tools.
4. Create new hotfix branch **release1.1** based on **release1**
5. Cherry-pick [this fix](https://gitlab.com/andrey.maslyanko96/interviewtestapplication/-/merge_requests/3) into **release1.1** using git cli or other tools.
6. Cherry-pick [this fix](https://gitlab.com/andrey.maslyanko96/interviewtestapplication/-/merge_requests/5) into **release1.1** using git cli or other tools.

