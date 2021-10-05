#this is a comment to add more information to you code
echo hello
echo world

msg="hello world"

echo $msg

echo What is your name? 
read UserInput
echo "Hello $UserInput, Welcome to the World"

num=40 
echo pick a number 
read num 
if [[$num ~eq 40]] 
echo "Number is equal to 40" 
else 
echo "you picked the wrong number"
fi

