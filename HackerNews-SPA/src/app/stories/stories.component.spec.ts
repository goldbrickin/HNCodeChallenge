/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { StoriesComponent } from './stories.component';
import { StoryFilterPipe } from '../_pipes/storyFilterPipe.pipe';
import { StoryCardComponent } from '../story-card/story-card.component';

describe('StoriesComponent', () => {
  let component: StoriesComponent;
  let fixture: ComponentFixture<StoriesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientModule],
      declarations: [ StoriesComponent, StoryFilterPipe, StoryCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StoriesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
