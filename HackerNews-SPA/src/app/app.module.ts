import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { StoriesComponent } from './stories/stories.component';
import { StoryCardComponent } from './story-card/story-card.component';
import { StoryFilterPipe } from './_pipes/storyFilterPipe.pipe';

@NgModule({
   declarations: [
      AppComponent,
      StoriesComponent,
      StoryCardComponent,
      StoryFilterPipe
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule
   ],
   providers: [],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
