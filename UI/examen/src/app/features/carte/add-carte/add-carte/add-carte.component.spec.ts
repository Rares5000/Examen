import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddCarteComponent } from './add-carte.component';

describe('AddCarteComponent', () => {
  let component: AddCarteComponent;
  let fixture: ComponentFixture<AddCarteComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AddCarteComponent]
    });
    fixture = TestBed.createComponent(AddCarteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
