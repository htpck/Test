const { Octokit } = require('github-rest-api');

const octokit = new Octokit({
  auth: process.env.GITHUB_TOKEN,
});

const owner = process.env.GITHUB_REPOSITORY.split('/')[0];
const repo = process.env.GITHUB_REPOSITORY.split('/')[1];
const issueNumber = process.env.GITHUB_EVENT.issue.number;

const comment = '🌟 If this issue was helpful, please consider giving it a star! 🌟';

octokit.rest.issues.createComment({
  owner,
  repo,
  issue_number: issueNumber,
  body: comment,
});
