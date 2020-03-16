import { TestBed, async } from '@angular/core/testing';
import { AppComponent } from './app.component';
import { StoriesComponent } from './stories/stories.component';
import { StoryCardComponent } from './story-card/story-card.component';
import { StoryFilterPipe } from './_pipes/storyFilterPipe.pipe';
import { HttpClientModule } from '@angular/common/http';

describe('AppComponent', () => {
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [
        AppComponent,
        StoriesComponent,
        StoryCardComponent,
        StoryFilterPipe
      ],
      imports: [
        HttpClientModule
      ]
    }).compileComponents();
  }));

  it('should create the app', () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app).toBeTruthy();
  });

  it(`should have as title 'HackerNews-SPA'`, () => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.title).toEqual('HackerNews-SPA');
  });

  it('should render title', () => {
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges();
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('.title').textContent).toContain('Hacker News Latest Stories');
  });
});
