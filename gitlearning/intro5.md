# Switch back to the main branch
git checkout main

# Merge my-feature branch into main
git merge my-feature

Now, run the following command to create a bare repo in the shared directory:

git init --bare

Set the name of the default branch for the new repo. To accomplish this step, you can change the HEAD branch to point at a different branch; in this case, the main branch:

git symbolic-ref HEAD refs/heads/main

The output says that the main branch is up to date (in other words, main on Alice's computer matches main in the shared repo). So, Alice merges the add-style branch into the main branch by running git merge --ff-only to perform a fast-forward merge. Then, Alice pushes main from their repo to the shared repo.

git merge --ff-only add-style
git push


main brach'de çalışırken commit edilmeden yeni bir branch'e geçmeden once saklamak için kullanılır

git stash

git stash list

git stash apply

git stash clear

git stash pop


commit atıldıktan sonra önceki commit'e geri dönülmesi

git checkout

git checkout 349dac7d0f45fe42014a7d3f4fc19be4a13a7c24

sonradan geri dönülme için

git switch master

commit'e atılmadan geri dönülmesi için

commit restore


önceki commit'lere dönerken önceki commitleri siler ve değişiklikler kalır

git reset 349dac7d0f45fe42014a7d3f4fc19be4a13a7c24


önceki commitlere önceki commitleri siler ve değişiklikleri de siler

git reset -hard 349dac7d0f45fe42014a7d3f4fc19be4a13a7c24


önceki commitlere dönerken önceki commitlerin değişikleri geri alır

git revert 349dac7d0f45fe42014a7d3f4fc19be4a13a7c24



commitler arasındaki farklara bakmak için

git diff


git diff 349dac7d0f45fe42014a7d3f4fc19be4a13a7c24 77ce77d6328c9039a649a1d2b88e9dd0cc30e5d1









