/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { StoryService } from './story.service';
import { HttpClient } from '@angular/common/http';
import { HttpClientModule } from '@angular/common/http';

describe('Service: Story', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientModule],
      providers: [StoryService]
    });
  });

  it('should ...', inject([StoryService], (service: StoryService) => {
    expect(service).toBeTruthy();
  }));
});
