import { Component, OnInit } from '@angular/core';
import { StoryService } from '../_services/story.service';
import { Story } from '../_models/story';

@Component({
  selector: 'app-stories',
  templateUrl: './stories.component.html',
  styleUrls: ['./stories.component.css']
})
export class StoriesComponent implements OnInit {
  stories: Story[];
  searchText: string;

  constructor(private storyService: StoryService) { }

  ngOnInit() {
    this.getStories();
  }

  getStories() {
    this.storyService.getStories().subscribe((stories: Story[]) => {
      this.stories = stories;
    }, error => {
      console.log(error);
    });
  }
}
