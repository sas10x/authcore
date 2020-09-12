﻿using System;
using System.Collections.Generic;
using Application.Comments;

namespace Application.Activities
{
    public class ActivityDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }
        // user
        public string DisplayName { get; set; }
        public string Username { get; set; }
        public string Avatar { get; set; }
        //[JsonProperty("attendees")]
        public ICollection<AttendeeDto> UserActivities { get; set; }
        public ICollection<CommentDto> Comments { get; set; }
    }
}