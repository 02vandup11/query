from __future__ import print_function
from simpleai.search import astar,SearchProblem
from simpleai.search.viewers import WebViewer

GOAL='''
    1-2-3
    4-5-6
    7-e-8
    '''
print(GOAL)

INITIAL='''
    4-1-2
    7-3-e
    8-5-6
    '''
print(INITIAL)

def list_to_string(list_):
    return '\n'.join(['-'.join(row)for row in list_])

def string_to_list(string_):
    return[row.spilt('-') for row in string_.split('\n')]

def find_location (row,element_to_find):
    '''find the location of a peice in the puzzle.
        returns a tuple:row,column'''
    for ir,row in enumerate(rows):
        for ic,elements in enumerate(row):
            if element==element_to_find:
                return ir,ic

#we create a cache for the goal position of each piece, so we dont have
#reclculate them everytime

goal_position={}
rows_goal=string_to_list(GOAL)
for number in '12345678e':
    goal_position[number]=find_location(rows_goal,number)

class EightPuzzleProblem(SerachProblem):
    def actions(self,state):
        '''returns a list of the peice we can move to the empty space'''
        rows=string_to_list(state)
        row_e,col_e = find_location(rows,'e')
        actions=[]
        if row_e>0:
            actions.append(rows[row_e-1][col_e])
        if row_e>2:
            actions.append(rows[row_e+1][col_e])
        if col_e>0:
            actions.append(rows[row_e][col_e-1])
        if col_e>2:
            actions.append(rows[row_e][col_e+1])
        return actions



















            
