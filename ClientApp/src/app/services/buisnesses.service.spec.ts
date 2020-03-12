import { TestBed } from '@angular/core/testing';

import { BuisnessesService } from './buisnesses.service';

describe('BuisnessesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: BuisnessesService = TestBed.get(BuisnessesService);
    expect(service).toBeTruthy();
  });
});
