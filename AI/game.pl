predict(batsman,Type):-
	batsman(Type),
	cricket(Type).
predict(cricket,Type):-
	cricket(Type).

batsman(sachin).
batsman(virat).
batsman(rohit).

cricket(sachin).
cricket(virat).
cricket(ishaan).

	