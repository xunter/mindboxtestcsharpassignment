--db structure

create table Article
(
	article_id bigint primary key identity,
	title nvarchar(512) null,
	body nvarchar(max) null
);

create table Tag
(
	phrase nvarchar(512) not null primary key
);

create table ArticleTag
(
	article_id bigint not null foreign key references Article(article_id),
	tag_phrase nvarchar(512) not null foreign key references Tag(phrase),
	primary key(article_id, tag_phrase)
)

--sql query

select Article.title, ArticleTag.tag_phrase
from ArticleTag 
	right join Article on ArticleTag.article_id = Article.article_id	
order by Article.title, ArticleTag.tag_phrase;
	