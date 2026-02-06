# QA Automation Portfolio – DemoQA Projects

## Overview
This repository contains **cross-language automation projects** for DemoQA:
- **Playwright (JavaScript/TypeScript)** – UI & API tests
- **Selenium (C# / NUnit)** – UI & E2E tests

It demonstrates:
- Manual QA experience (8+ years)
- QA Automation with **Page Object Model (POM)**
- UI & API testing
- End-to-End flows
- CI-ready structure

---

## Table of Contents
1. [Technologies](#technologies)
2. [Test Structure](#test-structure)
3. [Key Features](#key-features)
4. [E2E Testing](#e2e-testing)
5. [CI Integration](#ci-integration)
6. [How to Run](#how-to-run)
7. [Notes / Limitations](#notes--limitations)
8. [Contact](#contact)

---

## Technologies
- **Selenium WebDriver (C#)** – UI automation
- **NUnit** – test framework for C#
- **GitHub Actions** – CI pipeline
- **DemoQA** – test application

---

## Test Structure

Pages/
├── BasePage.cs
├── LoginPage.cs
├── FormsPage.cs
├── RegisterPage.cs

Tests/
├── BaseTest.cs
├── LoginTests.cs
├── FormsTests.cs
└── E2ETests.cs


---

## Key Features
- **Page Object Model (POM)** – clean, reusable, maintainable
- **Centralized waits** via BasePage
- **Safe JS clicks** to avoid ads / intercepts
- **Random user generation** for E2E tests
- **Negative & boundary tests**: invalid login, empty fields

---

## E2E Testing
- Demonstrates **end-to-end user journey**:
  1. Register a random user
  2. Attempt login
  3. Assert system behavior
- Notes:
  - DemoQA does **not reliably allow positive login verification** for newly registered users
  - Assert checks **system stability** (URL / page behavior) instead of fake success

---

## CI Integration
- **GitHub Actions** ready
- Runs tests in **headless mode**
- Reports test results + screenshots
- Example badge:
![Build Status](https://github.com/<your-username>/<your-repo>/actions/workflows/ci.yml/badge.svg)

---

## How to Run

- dotnet build
- dotnet test

---

## Notes / Limitations
- DemoQA is a demo site: some features (login, delete) are not fully functional
- Positive login E2E test validates flow behavior, not actual success
- Ads can intercept clicks → handled via JS click in BasePage
- All tests are isolated and repeatable

---

## Contact
Prepared by: Aleksandar Kirov

LinkedIn: https://www.linkedin.com/in/aleksandar-kirov-00925b110/

GitHub: https://github.com/alkirov