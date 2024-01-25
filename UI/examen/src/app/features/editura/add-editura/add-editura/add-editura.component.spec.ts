import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEdituraComponent } from './add-editura.component';

describe('AddEdituraComponent', () => {
  let component: AddEdituraComponent;
  let fixture: ComponentFixture<AddEdituraComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddEdituraComponent]
    });
    fixture = TestBed.createComponent(AddEdituraComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
