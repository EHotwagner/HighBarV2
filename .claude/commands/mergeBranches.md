Merge all feature branches into main using squash merges, then clean up.

## Steps

1. **Identify branches**: List all local branches. The main branch is `master` (or `main` if it exists). All other branches are feature branches.

2. **Ensure clean state**: Check for uncommitted changes. If any exist, commit them on the current branch with a descriptive message before proceeding.

3. **Push all branches to origin first**: Push each feature branch to origin so nothing is lost.

4. **Switch to main branch**: Checkout `master` (or `main`).

5. **Squash merge each feature branch**: For each feature branch (sorted alphabetically):
   - Run `git merge --squash <branch>`
   - Commit with message: `feat: merge <branch> (squash)`
   - If merge conflicts occur, stop and report them to the user.

6. **Delete feature branches locally**: `git branch -D <branch>` for each merged feature branch.

7. **Delete feature branches on remote**: `git push origin --delete <branch>` for each merged feature branch.

8. **Push main to origin**: `git push -u origin master` (or `main`).

9. **Report summary**: List which branches were merged and deleted.

IMPORTANT: Do NOT force push. If the push fails, report the error and ask the user what to do. Always confirm before deleting remote branches.
