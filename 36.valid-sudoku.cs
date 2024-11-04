/*
 * @lc app=leetcode id=36 lang=csharp
 *
 * [36] Valid Sudoku
 */

// @lc code=start
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for(int x = 0; x < 3; x++){
            for(int y = 0; y < 3; y++){
                if(!checkBox(board, x, y)){
                    return false;
                }
            }
        }

        for(int i = 0; i < 9; i++){
            if(!(checkRow(board, i) && checkCol(board, i))){
                return false;
            }
        }

        return true;
    }

    private bool checkRow(char[][] board, int row){
        char[] count = new char[10];
        for(int i = 0; i < 9; i++){
            if(board[row][i] != '.'){
                if(count[board[row][i] - '0'] > 0){
                    return false;
                }
                count[board[row][i] - '0']++;
            }
        }
        return true;
    }

    private bool checkCol(char[][] board, int col){
        char[] count = new char[10];
        for(int i = 0; i < 9; i++){
            if(board[i][col] != '.'){
                if(count[board[i][col] - '0'] > 0){
                    return false;
                }
                count[board[i][col] - '0']++;
            }
        }
        return true;
    }

    private bool checkBox(char[][] board, int x, int y){
        char[] count = new char[10];
        for(int i = 0; i < 3; i++){
            for(int j = 0; j < 3; j++){
                if(board[x * 3 + i][y * 3 + j] != '.'){
                    if(count[board[x * 3 + i][y * 3 + j] - '0'] > 0){
                        return false;
                    }
                    count[board[x * 3 + i][y * 3 + j] - '0']++;
                }
            }
        }
        return true;
    }
}
// @lc code=end

