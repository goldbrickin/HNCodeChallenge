/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { StoryCardComponent } from './story-card.component';
import { Story } from '../_models/story';

describe('StoryCardComponent', () => {
  let component: StoryCardComponent;
  let fixture: ComponentFixture<StoryCardComponent>;

  const story: Story = {
    id: 1,
    deleted: false,
    type: 'Story',
    by: 'Bryan',
    time: 1584140699,
    text: 'This is the text of a dummy story.',
    dead: false,
    parent: 0,
    poll: 1,
    kids: [],
    url: 'https://goldbrickin.org',
    score: 5,
    title: 'Dummy Story Title',
    parts: [],
    descendants: 0
  };

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StoryCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StoryCardComponent);
    component = fixture.componentInstance;
    fixture.componentInstance.story = story;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
