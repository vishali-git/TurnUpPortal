﻿Feature: TMFeature
  As a Turnup portal admin user
  I would like to create, edit and delete time and material records
  So that I can manage employees' time and materials successfully

  @regression
  Scenario: create time record with valid data
    Given I logged into Turnup portal successfully
    When I navigate to Time and Material page
    And I create a time record
    Then the record should be created successfully

  Scenario Outline: edit existing time record with valid data
    Given I logged into Turnup portal successfully
    When I navigate to Time and Material page
    And I update the '<Code>' and '<Description>' on an existing Time record
    Then the record should have the updated '<Code>' and '<Description>'

    Examples: 
      | Code            | Description |
      | Industry Connect | Laptop      |
      | TA Job Ready     | Mouse       |
      | EditedRecord     | Keyboard    |
