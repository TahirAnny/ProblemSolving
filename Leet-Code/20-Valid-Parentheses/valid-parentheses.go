/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.


Example 1:

Input: s = "()"
Output: true
*/

//Solution

package main

import "fmt"

func isValid(s string) bool {

	stack := []byte{}
	parenthesesMap := map[byte]byte{
		'(': ')',
		'[': ']',
		'{': '}',
	}
	for i := 0; i < len(s); i++ {
		sLen := len(stack)
		if len(stack) > 0 && parenthesesMap[stack[sLen-1]] == s[i] {
			stack = stack[:sLen-1]
		} else {
			stack = append(stack, s[i])
		}
	}
	return len(stack) == 0

}

func main() {
	fmt.Println(isValid("([{}})"))
	fmt.Println(isValid("([})"))
	fmt.Println(isValid("()"))
	fmt.Println(isValid("([{}])"))
}
