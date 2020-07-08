using AutoMapper;
using Infrastructure;
using Infrastructure.Entities;
using Website.Models;
using Website.ViewModel;

namespace Website.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMapFromEntitiesToViewModels();
            CreateMapFromViewModelsToEntites();
        }
        private void CreateMapFromViewModelsToEntites()
        {
            CreateMap<UpdateUserViewModel, ApplicationUser>();
            CreateMap<AuthorViewModel, Author>();
            CreateMap<BookViewModel, Book>();
            CreateMap<CommentViewModel, Comment>();
            CreateMap<GenreViewModel, Genre>();
            CreateMap<OrderViewModel, Order>();
            CreateMap<PostViewModel, Post>();
            CreateMap<PublisherViewModel, Publisher>();
            CreateMap<WishlistViewModel, Wishlist>();
        }

        private void CreateMapFromEntitiesToViewModels()
        {
            CreateMap<ApplicationUser, UpdateUserViewModel>();
            CreateMap<Author, AuthorViewModel>();
            CreateMap<Book, BookViewModel>();
            CreateMap<Comment, CommentViewModel>();
            CreateMap<Genre, GenreViewModel>();
            CreateMap<Order, OrderViewModel>();
            CreateMap<Post, PostViewModel>();
            CreateMap<Publisher, PublisherViewModel>();
            CreateMap<Wishlist, WishlistViewModel>();
        }

    }
}