-- Select All Data
create proc ShowData 
as
	select * from titles

ShowData

-- Delete Item by ID
create proc DeleteTitleById @ID varchar(6)
as
	Delete from titles where title_id = @ID

DeleteTitleById 'AS1111'

-- Update Item by ID
create proc UpdateTitleById @ID varchar(6),@TITILE varchar(80),@TYPE varchar(12)
as
	update titles
	set title = @TITILE, type=@TYPE
	where title_id = @ID

UpdateTitleById 'AS222','new title 2','new type'

-- Insert New Title
create proc InsertNewTitle @ID varchar(6),@TITILE varchar(80),@TYPE varchar(12)
as
	insert into titles (title_id, title, type)values(@ID,@TITILE,@TYPE)

InsertNewTitle 	'AS3333', 'Title 3', 'Type 3'

ShowData

create proc ShowPublisherData
as
	select * from publishers


ShowPublisherData





