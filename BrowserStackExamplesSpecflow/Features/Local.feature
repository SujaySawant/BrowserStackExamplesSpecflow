Feature: Local Feature

Open a locally hosted webpage.

@local
Scenario: Open local page
	Given I open a localhost page
	Then I should see BrowserStack Local
